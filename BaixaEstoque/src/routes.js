const express = require("express");
const routes = express.Router();
const ProdutoController = require('./controllers/ProdutoController');
const TransacaoController = require('./controllers/TransacaoController');


routes.get('/produtos', ProdutoController.index);
routes.get('/produtos_transacoes', ProdutoController.indexWithTransactions);
routes.get('/produtos_transacoes/:tipo', ProdutoController.indexWithTransactionsByType);
routes.get('/produtos/:id', ProdutoController.show);
//routes.get('/produtos_transacoes/:id', ProdutoController.showWithTransactions);
routes.post('/novo_produto', ProdutoController.store);
routes.put('/produtos/:id', ProdutoController.update);
routes.delete('/produtos/:id', ProdutoController.destroy);

routes.get('/transacoes', TransacaoController.index)
routes.post('/nova_transacao', TransacaoController.store);


module.exports = routes;