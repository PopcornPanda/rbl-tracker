# RBL Tracker
RBL Tracker provides an easy-to-use API for monitoring/tracking presence of ip addressees and domains on various blacklists.
Ips/Domains are user separated. Every user has their own list and can check only his own hosts.


## Getting started

You can deploy RBL Tracker by running example stack (api + mssql). 

Just clone the repo and execute `start.sh` script.

The first created user becomes automatically an administrator (user who can edit rbl lists).

You can also use our docker images:

- Canary build: 
```
docker pull registry.gitlab.com/herd-panel/ci-rbl-tracker:canary
``
- Latest stable build:
```
docker pull registry.gitlab.com/herd-panel/ci-rbl-tracker:latest
```

## Bundled Swagger
As an dotnet API, RBL tracker ships with bundled swagger and swagger UI, which can be easly disabled in `appsettings.json`

## TODO

- Create frontend application
- Run scheduled tasks inside the application itself
- Add support for adding CIDRs (it will be handled as name alias)
- Add groups 
- Add e-mail notification when IPs of a user in newly detected on RBL
- Add IP/Domain owner validation (we should use contact info from whois to validate ownership)
