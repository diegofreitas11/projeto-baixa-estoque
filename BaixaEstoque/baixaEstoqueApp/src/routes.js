/*import { createStackNavigator } from 'react-navigation-stack';
import { createSwitchNavigator} from 'react-navigation';*/

import React, { Component } from 'react';
import { Text } from 'react-native';

import { NavigationContainer } from '@react-navigation/native';
import { createDrawerNavigator } from '@react-navigation/drawer';
import Main from './pages/main';
import NewProduct from './pages/newProduct';

const Drawer = createDrawerNavigator();

const Root = ()  => 
    (
        <NavigationContainer>
            <Drawer.Navigator initialRouteName="Main">
                <Drawer.Screen 
                    name="main" 
                    component={Main}
                    options={{
                        drawerLabel: (() => <Text> Lista de produtos</Text>)
                    }}
                />

                <Drawer.Screen 
                    name="newProduct" 
                    component={NewProduct}
                    options={{
                        drawerLabel: (() => <Text> Novo Produto</Text>)
                    }}
                />
            </Drawer.Navigator>
        </NavigationContainer>
    )


export default Root;