<template>
  <div id="NovoForm">
      <div>
          <h3> Novo Curso</h3>
      </div>
    <div id="form-container">
        <form id="novoform-form">
            <div class="input-container">
                <textarea name="text" id="titulo" titulo="titulo" v-model="titulo" placeholder="Titulo"></textarea>
            </div>
            <div class="input-container">
                <textarea name="text" type="text" id="uploadcapa" uploadcapa="uploadcapa" v-model="uploadcapa" placeholder="upload capa"></textarea>
            </div>
            <div class="input-container">
                <textarea name="text" type="text" id="professor" professor="professor" v-model="professor" placeholder="Professor"></textarea>
            </div>  
            <div class="input-container">
                <textarea name="text" type="text" id="descricao" titulo="descricao" v-model="descricao" placeholder="Descrição"></textarea>
            </div>

            <div class="input-container">
                <textarea name="text" type="text" id="tituloaula" titulo="tituloaula" v-model="tituloaula" placeholder="Titulo da aula"></textarea>
            </div>
            <div class="input-container">
                <textarea name="text" type="text" id="linkaula" titulo="linkaula" v-model="linkaula" placeholder="Link da aula"></textarea>
            </div>
            <div class="input-container">
                <textarea name="text" type="text" id="descricaoaula" titulo="descricaoauala" v-model="descricaoaula" placeholder="Descriçao da aula"></textarea>
            </div>
            <div class="input-container">
                <input type="submit" id="submit-btn" value="Salvar">
            </div>
        </form>
    </div>
  </div>
</template>

<script>
export default {
    name: "NovoForm"
}
</script>



<style scoped>

#NovoForm{
    margin-top: 97px ;
    margin-left: 82px;
}

#form-container{
    margin-top: 66px;
}

.input-container{
    margin-top: 14px;
}

#descricao{
    padding-block-end: 121px;
    height: 150px;
} 

#descricaoaula{
    padding-block-end: 121px;
    height: 150px;
     
}

textarea{
    font-size: 18px;
    font-style: normal;
    font-weight: normal;
    width: 811px;
    height: 40px;
    background-color: #FFFFFF;
    border: 1px solid #AEAEAE;
    word-break: break-all;
    box-sizing: border-box;
    padding-inline-start: 10px;
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
