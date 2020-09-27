const Sequelize = require('sequelize');
const dbConfig = require('../config/database');
const connection = new Sequelize(dbConfig);

//models
const Produto = require('../src/models/Produto');
const Transacao = require('../src/models/Transacao');

//passando conexão
Produto.init(connection);
Transacao.init(connection);

Produto.associate(connection.models);




module.exports = connection;