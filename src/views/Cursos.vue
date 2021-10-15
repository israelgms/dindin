<template>
  <div class="cursos">
    <Header title="Cursos"/>
    <CardCursos />
  </div>
</template>

<script>
import Header from '../components/Header.vue'
import CardCursos from '../components/CardCursos.vue'

export default {
  name: 'Cursos',
  components: {
    Header,
    CardCursos,
  }
}
</script>
