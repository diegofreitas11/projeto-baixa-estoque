const express = require("express");
const routes = express.Router();
const produtoController = require('./controllers/ProdutoController');


routes.get('/produtos', produtoController.index);
routes.get('/produtos/:id', produtoController.show);
routes.post('/novo_produto', produtoController.store);
routes.put('/produtos/:id', produtoController.update);
routes.delete('/produtos/:id', produtoController.destroy);


module.exports = routes;