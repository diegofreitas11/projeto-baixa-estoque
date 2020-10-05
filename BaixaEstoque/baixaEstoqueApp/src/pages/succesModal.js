import React from 'react';

import { View, Modal, Text, TouchableOpacity } from 'react-native';
import Styles from './styles';


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
                <View style={Styles.container}>
                <View style={Styles.successBox}>
                    <Text style={Styles.title}>{props.message
                    } com sucesso!</Text>
                    <TouchableOpacity
                        onPress={props.closeModal}
                    >
                        <Text> OK</Text>
                    </TouchableOpacity>
                </View>
                </View>
            </Modal>
        </View>
    )
}

export default SuccessModal;