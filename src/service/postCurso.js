import api from './api'

export default{
    async postCurso(){
        try {
            const res = await api.post('/curso')
            return res
        } catch (error) {
            return error
        }
    }
}