import api from './api'

export default{
    async getCurso(){
        try {
            const res = await api.get('/curso')
            return res
        } catch (error) {
            return error
        }
    }
}