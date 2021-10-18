<template>
  <div class="titulo">
      <HeaderForm title="Novo Curso"/>
      <AulaForm />
      
  </div>
</template>

<script>

import HeaderForm from "../components/Forms/HeaderForm.vue"
import AulaForm from "../components/Forms/AulaForm.vue"

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