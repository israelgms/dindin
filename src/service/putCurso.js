import api from './api'

export default{
    async deleteCurso(){
        try {
            const res = await api.put('/curso')
            return res
        } catch (error) {
            return error
        }
    }
}