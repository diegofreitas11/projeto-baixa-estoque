
import React from 'react';
import { NavigationContainer, DrawerActions } from '@react-navigation/native';

import Main from './pages/main';
import List from './pages/list';
import Menu from './pages/menu';
import { createStackNavigator } from '@react-navigation/stack';



const Stack = createStackNavigator();


const Root = () => {
    return(
        <NavigationContainer>
            <Stack.Navigator 
                initialRouteName="Main" 
                headerMode="none"
               
            >
                <Stack.Screen 
                    name="Main"
                    component={Main}
    
                />
                <Stack.Screen 
                    name="Menu"
                    component={Menu}
                />
            </Stack.Navigator>
        </NavigationContainer>
    )
}


export default Root;