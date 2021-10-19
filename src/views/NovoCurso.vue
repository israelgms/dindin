<template>
  <div class="titulo">
      <HeaderForm title="Novo Curso"/>
      <AulaForm />
      
  </div>
</template>

<script>

import HeaderForm from "../components/HeaderForm.vue"
import AulaForm from "../components/AulaForm.vue"

export default {
  name: "NovoCurso",
  components: {
    HeaderForm,
    AulaForm,
  }
}
</script>

<style scoped>


</style>