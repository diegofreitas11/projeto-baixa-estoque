import {StyleSheet} from 'react-native';

export default Styles = StyleSheet.create({
    container: {
        justifyContent: 'center',
        alignItems: 'center',
        flex: 1
    },
    title:{
        fontFamily: 'roboto',
        fontWeight: 'bold',
        fontSize: 22,
        marginBottom: 10
    },
    inputLabel: {
        fontFamily: 'roboto',
        marginTop: 10
    },
    input: {
        borderBottomWidth: 1
    },
    button: {
        borderWidth: 1,
        borderRadius: 5,
        padding: 5,
        marginTop: 20,
        width: 200,
        height: 50,
        alignItems: 'center',
        alignSelf: 'center'
    },
    buttonInRow: {
        borderWidth: 1,
        borderRadius: 5,
        padding: 5,
        margin: 20,
        width: 100,
        height: 50,
        alignItems: 'center'
    },
    listItem: {
        borderWidth: 0.5,
        borderColor: "#cecece",
        borderRadius: 5,
        height: 100,
        margin: 5,
        shadowColor: '#cecece',
        elevation: 5,
        padding: 5
    },
    selectedListItem:{
        borderWidth: 0.5,
        borderColor: "#cecece",
        backgroundColor: "#cecece",
        borderRadius: 5,
        height: 100,
        margin: 5,
        shadowColor: '#cecece',
        elevation: 5,
        padding: 5
    },
    nextBox: {
        alignItems: 'center',
        backgroundColor: 'white',
        position: 'absolute',
        bottom: 0,
        height: 100,
        width: '100%'     
    },
    successBox: {
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
    }
})