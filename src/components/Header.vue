<template>
  <div>
    <h1 class="title">{{ title }}</h1>
    <p class="subtitle">Educação financeira é tudo de bom</p>
  </div>
</template>

<script>
export default {
  name: "Header",

  props: {
    title: "",
  },
};
</script>

<style scoped>
.title {
  font-size: 60px;
  font-weight: 700;
  color: #ff4081;
  margin: 81px 0 0 82px;
}
.subtitle {
  font-size: 20px;
  font-weight: 400;
  color: #555555;
  margin-left: 82px;
}

@media screen and (max-width: 514px) {
  .title {
    font-size: 40px;
    font-weight: 700;
    margin: 81px 0 0 20px;
  }
  .subtitle {
    margin-left: 20px;
  }
}
</style>