import { createStackNavigator } from 'react-navigation-stack';
import Main from './pages/main';
import NewProduct from './pages/newProduct'

const Root = createStackNavigator({
    NewProduct,
    Main
},{
    defaultNavigationOptions: {
        headerStyle:{
            backgroundColor: '#DA552F'
        },
        headerTintColor: '#CECECE'
    },
});

export default Root;