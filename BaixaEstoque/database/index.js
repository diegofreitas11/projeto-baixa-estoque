const Sequelize = require('sequelize');
const dbConfig = require('../config/database');
const connection = new Sequelize(dbConfig);

//models
const Produto = require('../src/models/Produto');

//passando conexão
Produto.init(connection);



module.exports = connection;