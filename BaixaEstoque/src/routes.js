const express = require("express");
const routes = express.Router();
const pcontroller = require('./controllers/produtoController');
const produtoController = new pcontroller();
const ccontroller = require('./controllers/compraController');
const compraController = new ccontroller();
const vcontroller = require('./controllers/vendaController');
const vendaController = new vcontroller();


/*connection.connect(err => {
    if(err)
        return console.log(err);
    return console.log('blz!');
});*/

//const produtoModel = require('./models/produtoModel');
//const model = new produtoModel();

routes.get("/produto", (req, res) => {
    produtoController.getProdutos((err, result) => {
        res.send(result);
    })
});


routes.post('/alterar', (req, res) => {
    produtoController.updateProduto(req, req.body.id, (err, result) =>{
        if(!err){
            res.send('produto atualizado')
         }else{
             console.log(err);
         }
    });
});

routes.get("/novoproduto", (req, res) => {
    return res.render('cadastroProduto');
});

//a ser implementado
/*routes.get("/", (req, res) =>{
    produtoController.getProdutos((err, result) =>{
        return res.render('listaProduto', {produtos : result});
    }); 
}*/

routes.get("/editar/:id", (req, res) =>{
    produtoController.getProduto(req.params.id, (err, result) =>{
        return res.render('cadastroProduto', {produto : result});
        
    });
});


routes.post('/inserir', (req, res) => {
    produtoController.addProduto(req, (err, result) => {
        if(!err){
            return res.render('cadastroProduto', {mensagem: 'Produto inserido'});
         }else{
             console.log(err);
         }
    });
});

routes.get("/", (req, res) => {
    produtoController.getProdutos((err, result) =>{
        return res.render('registroCompra', {produtos : result});
    }); 
});

routes.post("/registroCompra", (req, res) => {
    compraController.addTransacao(req, (err, result) => {
        if(!err){
            produtoController.getProdutos((err, result)=>{
                return res.render('registroCompra', {produtos: result, mensagem: 'Compra realizada'});
            });
        }else{
            console.log(err);
        }
    });
});

routes.get("/novavenda", (req, res)=>{
    produtoController.getProdutosComValor((err, result) =>{
        return res.render('registroVenda', {produtos : result});
        
    }); 
});

routes.post("/registroVenda", (req, res) => {
    console.log(req.body);
    vendaController.addTransacao(req, (err, result) => {
        if(!err){
            produtoController.getProdutosComValor((err, result)=>{
                return res.render('registroVenda', {produtos: result, mensagem: 'Venda realizada'});
            });
        }else{
            console.log(err);
        }
    })
})

module.exports = routes;