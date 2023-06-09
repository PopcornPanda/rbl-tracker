using System.Text.RegularExpressions;

namespace rbl_tracker.Services.Auth
{
    internal class Validators
    {
        internal enum PasswordScore
        {
            Blank = 0,
            TooShort = 1,
            RequirementsNotMet = 2,
            VeryWeak = 3,
            Weak = 4,
            Fair = 5,
            Medium = 6,
            Strong = 7,
            VeryStrong = 8
        }

        internal static PasswordScore CheckStrength(string password)
        {
            int score = 0;

            // using three requirements here:  min length and two types of characters (numbers and letters)
            bool blnMinLengthRequirementMet = false;
            bool blnRequirement1Met = false;
            bool blnRequirement2Met = false;

            // check for chars in password
            if (password.Length < 1)
                return PasswordScore.Blank;

            // if less than 6 chars, return as too short, else, plus one
            if (password.Length < 6)
            {
                return PasswordScore.TooShort;
            }
            else
            {
                score++;
                blnMinLengthRequirementMet = true;
            }

            // if 8 or more chars, plus one
            if (password.Length >= 8)
                score++;

            // if 10 or more chars, plus one
            if (password.Length >= 10)
                score++;

            // if password has a number, plus one
            if (Regex.IsMatch(password, @"[\d]", RegexOptions.ECMAScript))
            {
                score++;
                blnRequirement1Met = true;
            }

            // if password has lower case letter, plus one
            if (Regex.IsMatch(password, @"[a-z]", RegexOptions.ECMAScript))
            {
                score++;
                blnRequirement2Met = true;
            }

            // if password has upper case letter, plus one
            if (Regex.IsMatch(password, @"[A-Z]", RegexOptions.ECMAScript))
            {
                score++;
                blnRequirement2Met = true;
            }

            // if password has a special character, plus one
            if (Regex.IsMatch(password, @"[~`!@#$%\^\&\*\(\)\-_\+=\[\{\]\}\|\\;:'\""<\,>\.\?\/£]", RegexOptions.ECMAScript))
                score++;

            // if password is longer than 2 characters and has 3 repeating characters, minus one (to minimum of score of 3)
            List<char> lstPass = password.ToList();
            if (lstPass.Count >= 3)
            {
                for (int i = 2; i < lstPass.Count; i++)
                {
                    char charCurrent = lstPass[i];
                    if (charCurrent == lstPass[i - 1] && charCurrent == lstPass[i - 2] && score >= 4)
                    {
                        score++;
                    }
                }
            }

            if (!blnMinLengthRequirementMet || !blnRequirement1Met || !blnRequirement2Met)
            {
                return PasswordScore.RequirementsNotMet;
            }

            return (PasswordScore)score;
        }

        internal static bool VerifyPasswordHash(string passwowrd, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(passwowrd));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        internal static bool ValidateEmail(string email)
        {
            var _email = email.Trim();

            if (_email.EndsWith(".")) return false;

            var _validated = new System.Net.Mail.MailAddress(_email);

            return _validated.Address == _email;
        }

    }
}