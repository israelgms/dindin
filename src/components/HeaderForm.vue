<template>
  <div id="NovoForm">
    <div class="title-container">
      <h1 class="title">{{ title }}</h1>
    </div>
    <div id="form-container">
      <form id="novoform-form">
        <div class="input-container">
          <textarea
            name="text"
            id="titulo"
            titulo="titulo"
            v-model="titulo"
            placeholder="Titulo"
          ></textarea>
        </div>
        <div class="input-container">
          <textarea
            name="text"
            type="text"
            id="uploadcapa"
            uploadcapa="uploadcapa"
            v-model="uploadcapa"
            placeholder="Upload capa"
          ></textarea>
        </div>
        <div class="input-container">
          <textarea
            name="text"
            type="text"
            id="professor"
            professor="professor"
            v-model="professor"
            placeholder="Professor"
          ></textarea>
        </div>
        <div class="input-container">
          <textarea
            name="text"
            type="text"
            id="descricao"
            titulo="descricao"
            v-model="descricao"
            placeholder="Descrição"
          ></textarea>
        </div>

        <div class="form-container-aula">
          <div id="form-container-aula-numero">
            <p class="text-aula-numero">Aula 1 (automatizar número)</p>
          </div>

          <div class="input-container-copor">
            <textarea
              name="text"
              type="text"
              id="tituloaula"
              titulo="tituloaula"
              v-model="tituloaula"
              placeholder="Titulo da aula"
            ></textarea>
          </div>
          <div class="input-container-copor">
            <textarea
              name="text"
              type="text"
              id="linkaula"
              titulo="linkaula"
              v-model="linkaula"
              placeholder="Link da aula"
            ></textarea>
          </div>
          <div class="input-container-copor">
            <textarea
              name="text"
              type="text"
              id="descricaoaula"
              titulo="descricaoauala"
              v-model="descricaoaula"
              placeholder="Descriçao da aula"
            ></textarea>
          </div>

          <div id="button-salvar">
            <button>Salvar</button>
          </div>
        </div>
      </form>
    </div>
  </div>
</template>

<script>
export default {
  name: "HeaderForm",

  props: {
    title: "",
  },
};

</script>



<style scoped>
#NovoForm {
  margin-top: 97px;
  margin-left: 82px;
}

.input-container {
  margin-bottom: 14px;
}

#form-container-aula-numero {
  margin-top: 21px;
  margin-bottom: 16px;
}

.text-aula-numero{
  color: #419488;
  font-style: normal;
  font-size: 18px;
  font-weight: 500;
  line-height: 21px;
}

.input-container-copor {
  margin-bottom: 30px;
}

#button-salvar {
  margin-top: 43px;
  margin-bottom: 163px;
}


#descricao {
  padding-block-end: 121px;
  height: 150px;
}

#descricaoaula {
  padding-block-end: 121px;
  height: 150px;
}

textarea {
  font-size: 18px;
  font-style: normal;
  font-weight: normal;
  width: 811px;
  height: 40px;
  background-color: #ffffff;
  border: 1px solid #aeaeae;
  word-break: break-all;
  box-sizing: border-box;
  padding-inline-start: 10px;
  padding-top: 10px;
}

textarea[placeholder] {
  padding: auto;
}

button{
  font-size: 20px;
  font-weight: 400;
  background-color: #419488;
  border-radius: 62px;
  color: #ffffff;
  margin-top: 53px;
  width: 233px;
  height: 51px;
  cursor: pointer;
}

.title-container{
  width: 733px;
  height: 69px;
}

.title {
  font-size: 29px;
  font-weight: 700;
  color: #ff4081;
}

/* input[placeholder="Descrição"]{
    padding-block-end: 121px;
    padding-inline-end: 150px;
    height: 150px;
}

input[placeholder="Descrição da aula"]{
    padding-block-end: 121px;
    height: 150px;
} */
</style>
