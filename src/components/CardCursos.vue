<template>
<div>
  <div>
    <div class="container">
      <div class="image">
        <img src="../assets/images/image3.png" alt="" />
      </div>
      <div class="conteudo">
        <h2 class="title">Investimento para iniciantes</h2>
        <p>
          Sed ut perspiciatis unde omnis iste natus error sit voluptatem
          accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae
          ab illo inventore veritatis et quasi architecto beatae vitae dicta
          sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit
          aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos
          qui ratione voluptatem sequi nesciunt.
        </p>
        <button>Começar agora</button>
      </div>
    </div>
    <hr>
  </div>

  <div>
    <div class="container">
      <div class="image">
        <img src="../assets/images/image2.png" alt="" />
      </div>
      <div class="conteudo">
        <h2 class="title">Investimento para iniciantes</h2>
        <p>
          Sed ut perspiciatis unde omnis iste natus error sit voluptatem
          accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae
          ab illo inventore veritatis et quasi architecto beatae vitae dicta
          sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit
          aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos
          qui ratione voluptatem sequi nesciunt.
        </p>
        <button>Começar agora</button>
      </div>
    </div>
    <hr>
  </div>

  <div>
    <div class="container">
      <div class="image">
        <img src="../assets/images/image4.png" alt="" />
      </div>
      <div class="conteudo">
        <h2 class="title">Investimento para iniciantes</h2>
        <p>
          Sed ut perspiciatis unde omnis iste natus error sit voluptatem
          accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae
          ab illo inventore veritatis et quasi architecto beatae vitae dicta
          sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit
          aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos
          qui ratione voluptatem sequi nesciunt.
        </p>
        <button>Começar agora</button>
      </div>
    </div>
    <hr>
  </div>
</div>
</template>

<script>
export default {
  name: "CardCursos",
};
</script>

<style scoped>
.container {
  display: flex;
  margin: 95px 0 0 112px;
  max-width: 1157px;
  margin-bottom: 68px;
}

.conteudo {
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
    background-color: #C4C4C4;
    margin: 0 auto;    
}
</style>