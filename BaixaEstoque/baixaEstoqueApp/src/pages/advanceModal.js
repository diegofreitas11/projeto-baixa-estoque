import React from 'react';

import { View, Modal, Text, TouchableOpacity } from 'react-native';
import Styles from './styles';

const AdvanceModal = (props) => (
    <Modal
        visible={props.visible}
        transparent={true}
        animationType='slide'
        onRequestClose={() => {
            Alert.alert("");
        }}
    >
        <View style={Styles.container}>
            <View style={Styles.nextBox}>
                <Text>{props.message}</Text>
                <View style={{flexDirection: 'row'}}>
                    <TouchableOpacity 
                        style={Styles.buttonInRow}
                        onPress={props.advance()}
                    >
                        <Text style={{color: 'white'}}>Avançar</Text>
                    </TouchableOpacity>

                    <TouchableOpacity 
                        style={Styles.buttonInRow}
                        onPress={props.cancel()}
                    >
                        <Text style={{color: 'white'}}>Cancelar</Text>
                    </TouchableOpacity>
                </View>
            </View>
        </View>
    </Modal>
)

export default AdvanceModal;