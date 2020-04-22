const express = require('express');
const mysql = require('mysql');
const app = express();
const bodyParser = require('body-parser')


app.set('view engine', 'ejs');
app.use(bodyParser.urlencoded({extended:true}));
app.use("/", require("./src/routes"))
app.listen(3001);