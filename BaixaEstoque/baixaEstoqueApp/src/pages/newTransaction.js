import React, { Component, useRef } from 'react';
import { View, Text, FlatList, TextInput, TouchableOpacity, Alert } from 'react-native';
import api from '../services/api';
import Styles from './styles';
import { Formik, setNestedObjectValues } from 'formik';

import SuccessModal from './succesModal';


const Form = (props) => {
    
    const calculateValue = (quantity) => {
        var transactions = props.product.transacoes;
        var acc = 0, i = 0;

        while(quantity>0){
            if(quantity > transactions[i].quantidade){
                acc += transactions[i].valor * transactions[i].quantidade;
                quantity -= transactions[i].quantidade;
                i++;
            }else{
                acc += transactions[i].valor * quantity;
                quantity = 0;
            }
        }
        
        return acc.toString();
    }

    
    return(
        <Formik
            initialValues={{
                valor: '',
                quantidade: '',
            }}

            onSubmit={(values) => {
                props.save(values);
                values.valor = ''
                values.quantidade = ''
            }}

        >
            {({values, handleChange, handleSubmit}) => (
                <View style={{padding: 20}}>
                    <Text style={Styles.title}>{props.product.nome} </Text>

                    <Text style={Styles.inputLabel}>Quantidade</Text>
                    <TextInput
                        
                        value={values.quantidade}
                        keyboardType='numeric'
                        onChangeText={(text) => {
                            if(props.isSale){
                                if(props.max>=text){
                                    handleChange('quantidade')(text)
                                    let value = calculateValue(text);
                                    if(props.isSale) handleChange('valor')(value);
                                }else{
                                    handleChange('quantidade')('');
                                    handleChange('valor')('')
                                    Alert.alert("Não há essa quantidade em estoque");
                                }
                            }else{
                                handleChange('quantidade')(text)
                            }
                        }
                        }
                        style={Styles.input}
                    />

                    <Text style={Styles.inputLabel}>Valor {props.isSale ? 'Total': 'Unitário'}</Text>
                    <TextInput
                        
                        value={values.valor}
                        editable={!props.isSale}
                        keyboardType='numeric'
                        onChangeText={handleChange('valor')}
                        style={Styles.input}
                    />
                    
                    <TouchableOpacity
                        disabled={values.valor === '' || values.quantidade === ''}
                        onPress={handleSubmit}
                        style={Styles.button}
                    >
                        <Text>Enviar</Text>
                    </TouchableOpacity>
                </View>
            )
            }
        </Formik>
    )
}


class NewTransaction extends Component{
    state = {
        product: this.props.route.params.product,
        isModalVisible: false,
        isSale: this.props.route.params.sale,
        max: null
    }

    componentDidMount(){
        if(this.state.isSale){
            let product = this.calculateStock(this.state.product);
            let max = 0
            product.transacoes.forEach((item) => max+=item.quantidade);
            this.setState({
                product: product,
                max: max
            })
        } 

    }

    calculateStock = (product) => {
       
        //deduz as vendas das compras
        product.transacoes.forEach((item) => {
            if(item.tipo == "venda"){
                let quantity = item.quantidade;
                let i = 0;
                while(quantity > 0){
                    if(quantity > product.transacoes[i].quantidade 
                        && product.transacoes[i].tipo == "compra"){
                            quantity -= product.transacoes[i].quantidade;
                            product.transacoes[i].quantidade = 0;
                            i++;
                    }else if (quantity < product.transacoes[i].quantidade
                                && product.transacoes[i].tipo == "compra"){
                        product.transacoes[i].quantidade -= quantity; 
                        quantity = 0;
                        
                    }
                }

            }
        })

        product.transacoes = product.transacoes.filter((item) => item.tipo === "compra");
        console.log(product);

        return product;
        
    }

    save = async (values) =>{
        let isSale = this.state.isSale;
        let product;
        const transaction = {'produto_id': this.state.product.id, 
        'tipo': isSale ? 'venda':'compra', 'metodo': isSale? 'PEPS': 'NULL',...values}
        await api.post('nova_transacao', transaction)

        ///para atualizar a quantidade assim que cadastrar a transação
        if(isSale){
            var response = await api.get(`produtos_transacoes/${this.state.product.id}`)
            product = this.calculateStock(response.data);
        }else{
            product = this.state.product;
        }

        this.setState({
            isModalVisible: true,
            product: product
        })
    }
    

    render(){
        return(
            <View>
            <Form 
                product={this.state.product}
                save={(values) => this.save(values)}
                isSale={this.state.isSale}
                max={this.state.max}
            />

            <SuccessModal
                visible={this.state.isModalVisible}
                message='Transação inserida'
                closeModal={() => {
                    this.setState({
                        isModalVisible: false
                    })
                }} 
            />
           </View>
        )
    }
}

export default NewTransaction;