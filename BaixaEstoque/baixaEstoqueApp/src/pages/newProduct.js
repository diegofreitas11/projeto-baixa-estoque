import React, { Component, useRef } from 'react';
import { View, Text, FlatList, TextInput, Button, Alert } from 'react-native';
import api from '../services/api';
import { Formik } from 'formik';


function Form(props){
        const nome = useRef(null);
        const descricao = useRef(null);
        return(
           <Formik
                initialValues={{
                    nome: '',
                    descricao: ''
                }}
                onSubmit={values =>{
                    console.log(values)
                    props.save(values);
                    
                }}
           >

               {({values, handleChange, handleSubmit}) => (
                   <View>
                       <Text>Novo Produto</Text>

                       <Text>Insira o nome: </Text>
                       <TextInput
                            ref={nome}
                            value={values.nome}
                            onChangeText={handleChange('nome')}
                       />

                       <Text>Descrição: </Text>
                       <TextInput
                            ref={descricao}
                            value={values.descricao}
                            onChangeText={handleChange('descricao')}
                       />

                       <Button title="Entrar" onPress={handleSubmit}/>
                   </View>
               )}
           </Formik>
        )   
}

class NewProduct extends Component{

    createOneButtonAlert = () => {
        Alert.alert('ok', 'produto inserido com sucesso')
    }

    save = async (produto) => {
        try{
            await api.post('/novo_produto', produto);
            this.createOneButtonAlert();
        }catch(error){
            console.log(error);
        }
    }

    render(){
        return(
            <Form
                save={(produto) => this.save(produto)}
                alert={() => this.createOneButtonAlert()}
            />
        )
    }
}


export default NewProduct;