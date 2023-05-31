# RBL Tracker
[![build status](https://gitlab.com/herd-panel/rbl-tracker/badges/main/pipeline.svg)](https://gitlab.com/herd-panel/rbl-tracker/-/commits/main)

RBL Tracker provides an easy-to-use API for monitoring/tracking presence of ip addressees and domains on various blacklists.
Ips/Domains are user separated. Every user has their own list and can check only his own hosts.


## Getting started

You can deploy RBL Tracker by running example stack (api + mssql). 

Just clone the repo and execute `start.sh` script.

The first created user becomes automatically an administrator (user who can edit rbl lists).

## Bundled Swagger
As an dotnet API, RBL tracker ships with bundled swagger and swagger UI, which can be easly disabled in `appsettings.json`

## TODO

- Create frontend application
- Run scheduled tasks inside the application itself
- Add support for adding CIDRs (it will be handled as name alias)
- Add groups 
- Add e-mail notification when IPs of a user in newly detected on RBL
- Add IP/Domain owner validation (we should use contact info from whois to validate ownership)

# Security Policy

## Supported Versions

Use this section to tell people about which versions of your project are
currently being supported with security updates.

| Version | Supported          |
| ------- | ------------------ |
| < 1.0   | :white_check_mark: |

## Reporting a Vulnerability

Please create an issue for every vulnerability that You found in this project. 
It can be done either on Gitlab or on GitHub mirror.
