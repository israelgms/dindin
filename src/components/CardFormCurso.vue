<template>
  <div id="formcurso-container">
    <form id="form-curso" @submit.prevent="postForms">
      <div id="inputs-container">
        <div class="input-container">
          <input type="text" placeholder="titulo" v-model="titulo" />
        </div>
        <div class="input-container">
          <input type="text" placeholder="uploadcapa" v-model="upload_capa" />
        </div>
        <div class="input-container">
          <input type="text" placeholder="professor" v-model="professor" />
        </div>
        
        <div class="input-container">
          <textarea
            type="text"
            placeholder="descricao"
            v-model="descricao"
          ></textarea>
        </div>
      </div>
      <button @click="postForms()" type="submit">Salvar</button>
    </form>
  </div>
</template>

<script>

export default {
    name: "CardFormCurso",

  data() {
    return {
      titulo: "",
      upload_capa: "",
      professor: "",
      descricao: "",

    };
  },
  methods: {
    postForms() {
      const form = {
        titulo: this.titulo,
         upload_capa: this.upload_capa,
        professor: this.professor,       
        descricao: this.descricao,        
      };
      console.log(form);
    },
  },
};
</script>

<style>
</style>