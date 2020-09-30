import React, { Component, useRef } from 'react';
import { View, Text, FlatList, TextInput, Button, Alert, Modal, TouchableOpacity, StyleSheet } from 'react-native';
import api from '../services/api';
import { Formik } from 'formik';



const Form = (props) =>{
        const nome = useRef(null);
        const descricao = useRef(null);
        return(
           <Formik
                initialValues={{
                    nome: props.initialValues,
                    descricao: props.initialValues
                }}
                onSubmit={(values) =>{
                    props.save(values);
                    values.nome = "";
                    values.descricao = "";
                }}
           >

               {({values, handleChange, handleSubmit}) => (
                   <View style={{
                        padding: 20
                   }}>
                        <Text style={{
                            fontFamily: 'roboto',
                            fontWeight: 'bold',
                            fontSize: 22,
                            marginBottom: 10
                        }}>Novo Produto</Text>

                        <Text style={{
                            fontFamily: 'roboto',
                            marginTop: 10
                        }}>Insira o nome: </Text>
                        <TextInput
                            ref={nome}
                            value={values.nome}
                            onChangeText={handleChange('nome')}
                            style={{
                                borderBottomWidth: 1
                            }}
                        />

                        <Text style={{
                            fontFamily: 'roboto',
                            marginTop: 10
                        }}>Descrição: </Text>
                        <TextInput
                            ref={descricao}
                            value={values.descricao}
                            onChangeText={handleChange('descricao')}
                            style={{
                                borderBottomWidth: 1
                            }}
                        />
                        <View style={{alignItems: 'center'}}>
                        <TouchableOpacity 
                            onPress={handleSubmit}
                            style={{
                                borderWidth: 1,
                                borderRadius: 5,
                                padding: 5,
                                marginTop: 20,
                                width: 200,
                                alignItems: 'center'
                            }}
                        >
                            <Text>Enviar</Text>
                        </TouchableOpacity>
                        </View>
                   </View>
               )}
           </Formik>
        )   
}

const SuccessModal = (props) => {
    return(
        <View 
            style={{
                justifyContent: 'center',
                alignItems: 'center'
        }}>
            <Modal
                visible={props.visible}
                transparent={true}
                animationType='fade'
                onRequestClose={() => {
                    Alert.alert("Modal has been closed.");
                }}
            >
                <View style={{
                    justifyContent: 'center',
                    alignItems: 'center',
                    flex: 1
                }}>
                <View style={{
                    justifyContent: 'center',
                    alignItems: 'center',
                    
                    height: 150,
                    width: 250,
                    borderColor: '#00FA9A',
                    borderWidth: 2,
                    backgroundColor: 'white',
                    borderRadius: 20,
                    shadowColor: '#000',
                    elevation: 5,
                    padding: 5,
                    
                }}>
                    <Text style={{
                        fontFamily: 'roboto',
                        fontWeight: 'bold'
                    }}>Produto inserido com sucesso!</Text>
                    <TouchableOpacity 
                        onPress={props.closeModal}
                        style={{
                            marginTop: 5,

                        }}
                    >
                        <Text> OK</Text>
                    </TouchableOpacity>
                </View>
                </View>
            </Modal>
        </View>
    )
}

class NewProduct extends Component{
    state = {
        isModalVisible: false,
    }


    save = async (produto) => {
        try{
            await api.post('/novo_produto', produto);
            this.setState({
                isModalVisible: true
            })
        }catch(error){
            console.log(error);
        }
    }

    render(){
        return(
            <View>
                <Form
                    save={(produto) => this.save(produto)}
                    
                />
                <SuccessModal 
                    visible={this.state.isModalVisible}
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