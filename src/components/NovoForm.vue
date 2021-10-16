<template>
  <div>
    <h3> Novo Curso</h3>
    <!-- Ira avisar quando foi registrado com sucesso -->
    <p>Componente de mensagem</p>
    <!-- Ira avisar quando foi registrado com sucesso -->    
    <div class="form-container">
        <form id="novoform-form">
            <div class="input-container">
                <input type="text" id="titulo" titulo="titulo" v-model="titulo" placeholder="Titulo">
            </div>
            <div class="input-container">
                <input type="text" id="uploadcapa" uploadcapa="uploadcapa" v-model="uploadcapa" placeholder="upload capa">
            </div>
            <div class="input-container">
                <input type="text" id="professor" professor="professor" v-model="professor" placeholder="Professor">
            </div>
            <div class="input-container">
                <input type="text" id="descricao" titulo="descricao" v-model="descricao" placeholder="Descrição">
            </div>

            <div class="input-container">
                <input type="text" id="tituloaula" titulo="tituloaula" v-model="tituloaula" placeholder="Titulo da aula">
            </div>
            <div class="input-container">
                <input type="text" id="linkaula" titulo="linkaula" v-model="linkaula" placeholder="Link da aula">
            </div>
            <div class="input-container">
                <input type="text" id="descricaoaula" titulo="descricaoauala" v-model="descricaoaula" placeholder="Descriçao da aula">
            </div>
            <div class="input-btn">
                <input type="submit" class="submit-btn" value="Salvar">
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

.form-container{
    left: 83px;
    background-color: black;
}

input[type=text]{
    width: 811px;
    height: 40px;
    background-color: #FFFFFF;
    border: 1px solid #AEAEAE;
    box-sizing: border-box;
}


</style>
