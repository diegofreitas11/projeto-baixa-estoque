const express = require('express');
const mysql = require('mysql');
const cors = require('cors');
const app = express();
const bodyParser = require('body-parser')

require('./database');

app.set('view engine', 'ejs');
app.use(bodyParser.urlencoded({extended:true}));
app.use(express.json());
app.use(cors());
app.use("/", require("./src/routes"))
app.listen(3001);