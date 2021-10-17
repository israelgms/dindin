<template>
  <div id="NovoForm">
    <div>
      <h3>Novo Curso</h3>
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
            <p>Aula 1 (automatizar número)</p>
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
            <input type="submit" id="submit-btn" value="Salvar" />
          </div>
        </div>
      </form>
    </div>
  </div>
</template>

<script>
export default {
  name: "NovoForm",
};
</script>



<style scoped>
#NovoForm {
  margin-top: 97px;
  margin-left: 82px;
}

#form-container {
  margin-top: 66px;
}

.input-container {
  margin-top: 14px;
}

#form-container-aula-numero {
  margin-top: 21px;
  margin-bottom: 16px;
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
