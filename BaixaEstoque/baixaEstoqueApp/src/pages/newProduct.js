import React, { Component, useRef } from 'react';
import { View, Text, TextInput, Alert, Modal, TouchableOpacity } from 'react-native';
import api from '../services/api';
import { Formik } from 'formik';
import Styles from './styles';
import SuccessModal from './succesModal'



const Form = (props) => {
        const nome = useRef(null);
        const descricao = useRef(null);

        return(
           <Formik
                initialValues={{
                    nome: '',
                    descricao: ''
                }}

                onSubmit = {(values) => {
                    props.save(values);
                    values.nome = ""; 
                    values.descricao = "";
                }}
           >

               {({values, handleChange, handleSubmit}) => (
                   <View style={{
                        padding: 20
                   }}>
                        <Text style={Styles.title}>Novo Produto</Text>
                        <Text style={Styles.inputLabel}>Insira o nome: </Text>
                        <TextInput
                            ref={nome}
                            value={values.nome}
                            onChangeText={handleChange('nome')}
                            style={Styles.input}
                        />

                        <Text style={Styles.inputLabel}>Descrição: </Text>
                        <TextInput
                            ref={descricao}
                            value={values.descricao}
                            onChangeText={handleChange('descricao')}
                            style={Styles.input}
                        />
                        
                        <TouchableOpacity 
                            onPress={handleSubmit}
                            style={Styles.button}
                        >
                            <Text>Enviar</Text>
                        </TouchableOpacity>
                        
                   </View>
               )}
           </Formik>
        )   
}


class NewProduct extends Component{
    
    state = {
        isModalVisible: false,
    }

    save = async (produto) => {
        try{
            await api.post('novo_produto', produto);
            this.setState({
                isModalVisible: true
            })
        }catch(error){
            console.log(error)
        }
    }


    render(){
        return(
            <View style={{backgroundColor: 'white', flex: 1}}>
                <Form 
                    save={(produto) => this.save(produto)}
                />
                <SuccessModal 
                    visible={this.state.isModalVisible}
                    message='Produto inserido'
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


export default NewProduct;