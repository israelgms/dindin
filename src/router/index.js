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
  },
  {
    path: '/curso',
    name: 'Curso',
    component: () => import(/* webpackChunkName: "curso" */ '../views/Curso.vue')
  },
  {
    path: '/novocurso',
    name: 'NovoCurso',
    component: () => import(/* webpackChunkName: "novo curso" */ '../views/NovoCurso.vue')
  },
]

const router = new VueRouter({
  routes,
  mode: 'history'
})

export default router
