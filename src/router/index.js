import Vue from 'vue'
import VueRouter from 'vue-router'
import Cursos from '../views/Cursos.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Cursos',
    component: Cursos
  },
  {
    path: '/painel',
    name: 'Painel',
    component: () => import(/* webpackChunkName: "painel" */ '../views/Painel.vue')
  }
]

const router = new VueRouter({
  routes
})

export default router
