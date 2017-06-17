<template>
  <div class="feed-row">
    <div class="demo-card-square mdl-card mdl-shadow--2dp">
      <div class="mdl-card__title mdl-card--expand" style="background-color:#2F6778">
        <h2 class="mdl-card__title-text">Rio de Janeiro</h2>
      </div>
      <div class="mdl-card__supporting-text">2 demandas
      </div>
      <div class="mdl-card__actions mdl-card--border">
        <a class="mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect">
          Ver Detalhes
        </a>
      </div>
    </div>

    <div class="demo-card-square mdl-card mdl-shadow--2dp">
      <div class="mdl-card__title mdl-card--expand" style="background-color:#4BA38C">
        <h2 class="mdl-card__title-text">São Paulo</h2>
      </div>
      <div class="mdl-card__supporting-text">1 demanda
      </div>
      <div class="mdl-card__actions mdl-card--border">
        <a class="mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect">
          Ver Detalhes
        </a>
      </div>
    </div>

    <div class="demo-card-square mdl-card mdl-shadow--2dp">
      <div class="mdl-card__title mdl-card--expand" style="background-color:#DE4549">
        <h2 class="mdl-card__title-text">Belho Horizonte</h2>
      </div>
      <div class="mdl-card__supporting-text">0 demandas
      </div>
      <div class="mdl-card__actions mdl-card--border">
        <a class="mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect">
          Ver Detalhes
        </a>
      </div>
    </div>

    <div class="demo-card-square mdl-card mdl-shadow--2dp">
      <div class="mdl-card__title mdl-card--expand" style="background-color:#FFC26B">
        <h2 class="mdl-card__title-text">Florianópolis</h2>
      </div>
      <div class="mdl-card__supporting-text">3 demandas
      </div>
      <div class="mdl-card__actions mdl-card--border">
        <a class="mdl-button mdl-button--colored mdl-js-button mdl-js-ripple-effect">
          Ver Detalhes
        </a>
      </div>
    </div>
  </div>
</template>

<script>

export default {
  name: 'feed',
  data () {
    return {
      msg: 'Feed'
    }
  }
}
</script>

<style scoped>

  .feed-row {
    display: flex;
    flex-direction: row;
    margin: 20px;
  }

  .demo-card-square.mdl-card {
    width: 320px;
    height: 280px;
    margin: 20px;
  }

  .demo-card-square > .mdl-card__title {
    color: #fff;
    background-color: rgb(233, 30, 99);
  }

</style>
