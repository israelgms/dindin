<template>
  <div id="Container-FormCurso">
    <form @submit.prevent="postForms">
      <div class="input-container">
        <input type="text" placeholder="titulo" v-model="titulo" />
      </div>
      <div class="input-container">
        <input type="text" placeholder="professor" v-model="professor" />
      </div>
      <div class="input-container">
        <input type="text" placeholder="descricao" v-model="descricao" />
      </div>
      <div class="input-container">
        <input type="text" placeholder="teste" v-model="teste" />
      </div>
      <button type="submit">Salvar</button>
    </form>
  </div>
</template>

<script>
export default {
  data() {
    return {
      titulo: "",
      professor: "",
      descricao: "",
      teste: "",
    };
  },
  methods: {
    postForms() {
      const form = {
        titulo: this.titulo,
        professor: this.professor,
        descricao: this.descricao,
        teste: this.teste,
      };
      console.log(form);
    },
  },
};
</script>

<style>
</style>