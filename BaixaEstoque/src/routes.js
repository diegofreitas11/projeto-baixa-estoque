const express = require("express");
const routes = express.Router();
const ProdutoController = require('./controllers/ProdutoController');
const TransacaoController = require('./controllers/TransacaoController');


routes.get('/produtos', ProdutoController.index);
routes.get('/produtos_transacoes', ProdutoController.indexWithTran);
routes.get('/produtos/:id', ProdutoController.show);
routes.get('/produtos_transacoes/:id', ProdutoController.showWithTran);
routes.post('/novo_produto', ProdutoController.store);
routes.put('/produtos/:id', ProdutoController.update);
routes.delete('/produtos/:id', ProdutoController.destroy);

routes.post('/nova_transacao', TransacaoController.store);


module.exports = routes;