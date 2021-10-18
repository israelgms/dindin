<template>
  <div id="HeaderForm">
    <div id="title-container">
      <h1 class="title">{{ title }}</h1>
    </div>
    <div id="form-container">
      <form id="novoform-form">

        <div class="input-container">
          <input
            name="text"
            id="titulo"
            titulo="titulo"
            v-model="titulo"
            placeholder="Titulo"
          >
        </div>
        <div class="input-container">
          <input
            name="text"
            type="text"
            id="uploadcapa"
            uploadcapa="uploadcapa"
            v-model="uploadcapa"
            placeholder="Upload capa"
          >
        </div>
        <div class="input-container">
          <input
            name="text"
            type="text"
            id="professor"
            professor="professor"
            v-model="professor"
            placeholder="Professor"
          >
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
#HeaderForm {
  margin-top: 97px;
  margin-left: 82px;
}

.input-container {
  margin-bottom: 14px;
}

#descricao {
  padding-block-end: 121px;
  height: 150px;
}

textarea, input{
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

#title-container {
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
