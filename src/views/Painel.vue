<template>
  <div class="painel">
    <Header title="Painel Administrativo"/>
    <PainelAcoes />
  </div>
</template>

<script>
import Header from '../components/Header.vue'
import PainelAcoes from '../components/PainelAcoes.vue'

export default {
  name: 'Painel',
  components: {
    Header,
    PainelAcoes,
  }
}
</script>
