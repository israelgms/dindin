<template>
  <div>
    <div class="container" v-for="curso in listCursos" 
    :key="curso.cursoId"
    >
      <div class="image">
        <img :src= curso.cursoFoto alt="" />
      </div>
      <div class="conteudo">
        <h2 class="title">{{curso.cursoName}}</h2>
        <p>
          {{curso.cursoDescricao}}
        </p>
        <button>Começar agora</button>
      </div>
    </div>
  </div>
</template>

<script>
import { mapActions, mapGetters } from 'vuex'

export default {
  name: "CardCursos",
  mounted() {
    this.getCursos();
  },
  methods: {
    ...mapActions("getCurso", ["getCursos"]),
  },
  computed: {
    ...mapGetters("getCurso", ["listCursos"]),
  },
};
</script>
<style scoped>
.container {
  display: flex;
  margin: 95px 50px 68px 112px;
}
.conteudo {
  width: 100%;
  max-width: 724px;
  margin-left: 53px;
}
.title {
  margin: 21px 0 37px 0;
  color: #ff4081;
  font-size: 35px;
  font-weight: 700;
}
p {
  font-size: 18px;
  font-weight: 300;
}
button {
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
hr {
  width: 1244px;
  height: 5px;
  background-color: #c4c4c4;
  margin: 0 auto;
}

@media screen and (max-width: 1000px) {
  .container {
    display: flex;
    margin: 95px 50px 68px 50px;
  }

  .image img {
    width: 320px;
    height: 320px;
  }

  .conteudo {
    max-width: 100%;
  }

  button {
    margin-top: 10px;
  }
}

@media screen and (max-width: 803px) {
  .container {
    flex-wrap: wrap;
    justify-content: center;
    text-align: center;
    margin: 40px 10px 20px 10px;
  }

  .conteudo {
    margin-left: 0;
  }

  button {
    margin-top: 25px;
  }
}
</style>