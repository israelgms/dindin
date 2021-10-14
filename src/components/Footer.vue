<template>
  <div class="container">
    <div class="footer">
        <div>
          <img class="logo" src="../assets/dindin-logo.png" alt="" />
        </div>
        <div class="texto">
          <h2 class="titulo">dindin</h2>
          <p class="subtitulo">educação financeira</p>
        </div>
      </div>
    </div>
</template>

<script>
export default {
  name: "Footer",
};
</script>

<style scoped>
.container {
  background-color: #419488;
  height: 207px;
  color: #ffffff;
}

.footer {
    display: flex;
}

.texto, .logo {
  margin: 53px 10px 0 0;
}

.logo {
    margin-left: 127px;
}

.titulo {
  font-weight: 500;
  font-size: 66px;
  
}

.subtitulo {
  font-weight: 300;
  font-size: 19px;
  margin-left: 8px;
}
</style>