<template>
  <form action="" @submit.prevent="salvar">
    <div id="HeaderForm">
      <div id="title-container">
        <h1 class="title">{{ title }}</h1>
      </div>
    </div>
    <div id="form-container">
      <div class="input-container">
        <input
          name="text"
          id="titulo"
          titulo="titulo"
          v-model="informacaocurso.titulo"
          placeholder="Titulo"
        />
      </div>
      <div class="input-container">
        <input
          name="text"
          type="text"
          id="uploadcapa"
          uploadcapa="uploadcapa"
          v-model="informacaocurso.uploadcapa"
          placeholder="Upload capa"
        />
      </div>
      <div class="input-container">
        <input
          name="text"
          type="text"
          id="professor"
          professor="professor"
          v-model="informacaocurso.professor"
          placeholder="Professor"
        />
      </div>
      <div class="input-container">
        <textarea
          name="text"
          type="text"
          id="descricao"
          titulo="descricao"
          v-model="informacaocurso.descricao"
          placeholder="Descrição"
        ></textarea>
      </div>
    </div>

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
          <div id="button-acrescentar-aula">
            <button @click="removerAula(index)" type="button">
              Excluir aula
            </button>
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
        <button type="submit">Salvar</button>
      </div>
    </div>
  </form>
</template>

<script>
import api from "../service/api";

export default {
  name: "Form",

  props: {
    title: "",
  },

  data() {
    return {
      informacaocurso: {
        titulo: "",
        uploadcapa: "",
        professor: "",
        descricao: "",
      },
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
  methods: {
    removerAula(index){
				this.listagemAulas.splice(index, 1);
    },
    acrescentarAula() {
      this.listagemAulas.push({
        titulo: "",
        link: "",
        descricao: "",
      });
    },
    salvar() {
      api.post("/curso", {
        cursoName: this.informacaocurso.titulo,
        cursoFoto: this.informacaocurso.uploadcapa,
        cursoDescricao: this.informacaocurso.descricao,
        cursoProfessor: this.informacaocurso.professor
      });
    },
  },
};
</script>

<style scoped>
#AulaForm {
  margin-left: 82px;
}

#HeaderForm {
  margin-top: 97px;
  margin-left: 82px;
}

#form-container-aula-numero {
  margin-top: 21px;
  margin-bottom: 16px;
}

#descricao {
  padding-block-end: 121px;
  height: 150px;
}

#descricaoaula {
  padding-block-end: 121px;
  height: 150px;
}

.input-container {
  margin-bottom: 14px;
  margin-left: 82px;
}

.input-container-aula {
  margin-bottom: 30px;
}

textarea,
input {
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
  margin-left: 82px;
}

#title-container {
  width: 733px;
  height: 69px;
  font-weight: 700;
}

.title {
  font-size: 29px;
  font-weight: 700;
  color: #ff4081;
}
</style>