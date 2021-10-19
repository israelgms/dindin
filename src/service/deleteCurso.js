import api from './api'

export default{
    async deleteCurso(){
        try {
            const res = await api.delete('/curso')
            return res
        } catch (error) {
            return error
        }
    }
}