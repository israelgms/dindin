<template>
  <div id="formaula-container">
    <form action="form-aula" >
      <div v-for="(aula, index) in listagemAulas" :key="index">
        <div id="AulaForm">
          <div class="form-container-aula">
            <div id="form-container-aula-numero">
              <p class="text-aula-numero">Aula {{ index + 1 }}</p>
            </div>
            <div class="input-container-aula">
              <input
                name="text"
                type="text"
                id="tituloaula"
                titulo="tituloaula"
                v-model="aula.titulo"
                placeholder="Titulo da aula"
              />
            </div>
            <div class="input-container-aula">
              <input
                name="text"
                type="text"
                id="linkaula"
                titulo="linkaula"
                v-model="aula.link"
                placeholder="Link da aula"
              />
            </div>
            <div class="input-container-aula">
              <textarea
                name="text"
                type="text"
                id="descricaoaula"
                titulo="descricaoauala"
                v-model="aula.descricao"
                placeholder="Descriçao da aula"
              ></textarea>
            </div>
          </div>
        </div>
      </div>

      <div id="buttons">
        <div id="button-acrescentar-aula">
          <button @click="acrescentarAula()" type="button">
            Acrescentar Aula
          </button>
        </div>

        <div id="button-salvar">
          <button @click="postForms()" type="submit">Salvar</button>
        </div>
      </div>
    </form>
  </div>
</template>

<script>

export default {

    name: "CardFormAula",

  data() {
    return {
      listagemAulas: [
        {
          titulo: "",
          link: "",
          descricao: "",
        },
        {
          titulo: "",
          link: "",
          descricao: "",
        },
      ],
    };
  },
  methods:{
        postForms(){
            const form = { 
                titulo: this.aula.titulo,
                link: this.aula.link,
                descricao: this.aula.descricao,
            }
            console.log(form)
        }
    }

};
</script>

<style>
</style>