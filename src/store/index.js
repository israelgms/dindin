import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

import deleteCurso from './modules/deleteCurso'
import getCurso from './modules/getCurso'
import postCurso from './modules/postCurso'
import putCurso from './modules/putCurso'


export default new Vuex.Store({
  state: {
  },
  mutations: {
  },
  actions: {
  },
  modules: {
    deleteCurso,
    getCurso,
    postCurso,
    putCurso,
  }
})
