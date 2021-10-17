<template>

  <form action="">
    <div id="AulaForm" >
      <div class="form-container-aula">
        <div id="form-container-aula-numero">
          <p class="text-aula-numero">Aula 1</p>
        </div>
        <div class="input-container-aula">
          <input
            name="text"
            type="text"
            id="tituloaula"
            titulo="tituloaula"
            v-model="tituloaula"
            placeholder="Titulo da aula"
          >
        </div>
        <div class="input-container-aula">
          <input
            name="text"
            type="text"
            id="linkaula"
            titulo="linkaula"
            v-model="linkaula"
            placeholder="Link da aula"
          >
        </div>
        <div class="input-container-aula">
          <textarea
            name="text"
            type="text"
            id="descricaoaula"
            titulo="descricaoauala"
            v-model="descricaoaula"
            placeholder="Descriçao da aula"
          ></textarea>
        </div>

        <div id="buttons">
          <div id="button-acrescentar-aula">
            <button @click="acrescentarAula">Acrescentar Aula</button>
          </div>
          <div id="button-salvar">
            <button @click="salvaForm">Salvar</button>
          </div>
        </div>
        
      </div>
    </div>
  </form>
</template>

<script>
export default {
  name: "AulaForm",

};


</script>

<style scoped>
#AulaForm {
  margin-left: 82px;
}

#form-container-aula-numero {
  margin-top: 21px;
  margin-bottom: 16px;
}

#descricaoaula {
  padding-block-end: 121px;
  height: 150px;
}

.input-container-aula {
  margin-bottom: 30px;
}

textarea, input {
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

.text-aula-numero {
  color: #419488;
  font-style: normal;
  font-size: 18px;
  font-weight: 500;
  line-height: 21px;
}

#button-acrescentar-aula {
  margin-top: 43px;
}

#button-salvar {
  margin-top: 15px;
  margin-bottom: 163px;
}

button {
  font-size: 20px;
  font-weight: 400;
  background-color: #419488;
  border-radius: 62px;
  color: #ffffff;
  width: 233px;
  height: 51px;
  cursor: pointer;
}
</style>