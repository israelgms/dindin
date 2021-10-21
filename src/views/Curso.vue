<template>
  <div>
    <div class="container">
      <div class="curso">
        <div class="conteudo">
          <h1>Investimento para iniciantes</h1>
          <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. </p>
        </div>
        <div class="image">
          <img src="../assets/images/image3.png" alt="">
        </div>
      </div>

      <div class="aula">
        <div class="video">
          <iframe width="462" height="261" src="https://www.youtube.com/embed/l-aS0XSmShM" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
        </div>
        <div>
          <h2>Aula 1</h2>
          <p>Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. 

Ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. </p>
        </div>
      </div>
      <hr>

    </div>

    



  </div>
</template>

<script>
export default {

}
</script>

<style scoped>

  .curso {
    display: flex;
  }

  h1 {
    max-width: 450px;
    font-size: 55px;
    font-weight: 700;
    color: #FF4081;
    margin: 94px 0 22px 202px;
  }

  .conteudo p {
    max-width: 461px;
    font-size: 20px;
    font-weight: 300;
    margin-left: 202px;
  }

  .image img {
    margin: 81px 0 81px 88px;
  }

  .aula {
    display: flex;
    background-color: #F6F6F6;
  }

  .aula p {
    max-width: 501px;
    margin-left: 76px;
    font-size: 20px;
    font-weight: 300;
  }

  iframe {
    margin: 75px 76px 73px 213px
  }

  h2 {
    font-size: 35px;
    font-weight: 700;
    color: #FF4081;
    margin: 75px 0 26px 76px;
  }

  hr {
    margin: 0 auto;
    width: 1244px;
    height: 3px;
    background-color: #C4C4C4;
  }
</style>