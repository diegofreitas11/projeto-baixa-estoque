import React, { Component, useRef } from 'react';
import { View, Text, FlatList, TextInput,  TouchableOpacity } from 'react-native';
import api from '../services/api';
import Styles from './styles';
import { Formik } from 'formik';

import SuccessModal from './succesModal';


const Form = (props) => {
    const valor = useRef(null);
    const quantidade = useRef(null);

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
                    <Text style={Styles.inputLabel}>Valor Unitário</Text>
                    <TextInput
                        ref={valor}
                        value={values.valor}
                        keyboardType='numeric'
                        onChangeText={handleChange('valor')}
                        style={Styles.input}
                    />
                    <Text style={Styles.inputLabel}>Quantidade</Text>
                    <TextInput
                        ref={quantidade}
                        value={values.quantidade}
                        keyboardType='numeric'
                        onChangeText={handleChange('quantidade')}
                        style={Styles.input}
                    />
                    <TouchableOpacity
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

class NewPurchase extends Component{
    state = {
        product: this.props.route.params.product,
        isModalVisible: false
    }
    save = async (values) =>{
        const venda = {'produto_id': this.state.product.id, 
        'tipo': 'compra' ,...values}
        await api.post('nova_transacao', venda)

        this.setState({
            isModalVisible: true
        })
    }
    

    render(){
        return(
            <View>
            <Form 
                product={this.state.product}
                save={(values) => this.save(values)}
            />

            <SuccessModal
                visible={this.state.isModalVisible}
                message='Compra inserida'
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

export default NewPurchase;