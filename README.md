# mongo-url-parser

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

A small library to parse mongo url strings to extract the database name.

Ever needed to manually run through a connection string provided by MongoDb Atlas to extract the db name? Then this library is for you.

## Usage

```chsarp
using MongoUrlParser;
...

var databaseConnectionString = "mongodb://user:password@host:port/database-name?otheroptions"; // any mongodb connection string
var (dbUrl, dbName) = Parser.Parse(databaseConnectionString);

// dbUrl: mongodb://user:password@host:port?otheroptions
// dbName: database-name
```
