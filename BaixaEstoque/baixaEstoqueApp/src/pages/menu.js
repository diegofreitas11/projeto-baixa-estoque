import { NavigationContainer } from '@react-navigation/native';
import { createDrawerNavigator } from '@react-navigation/drawer';
import Main from './main';
import newProduct from './newProduct'

const Drawer = createDrawerNavigator();

const Menu = () => {
    return(
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
                    component={newProduct}
                    options={{
                        drawerLabel: (() => <Text> Novo Produto</Text>)
                    }}
                />
            </Drawer.Navigator>
        </NavigationContainer>
    )
}

export default Menu;