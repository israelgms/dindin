import serviceApi from '../../service/getCurso'

export default{
    namespaced: true,

    state:{
        getCursos: []
    },
    mutations:{
        SET_CURSOS(state, payload){
            state.getCursos = payload
        }
    },
    actions:{
        async getCursos(context){
            const res = await serviceApi.getCursos()
            context.commit('SET_CURSOS', res.data) 
        }
    },
    getters:{
        listCursos(state){
            return state.getCursos 
        }
    }
}