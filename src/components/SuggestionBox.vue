<template>
  <div class="suggestion-box">
    <div class="input-container mdl-card mdl-shadow--4dp">
      <form action="#">
        <div class="input-text mdl-textfield mdl-js-textfield">
          <input class="mdl-textfield__input" type="text" id="name-input">
          <label class="mdl-textfield__label" for="name-input">Nome</label>
        </div>
        <div class="input-text mdl-textfield mdl-js-textfield">
          <input class="mdl-textfield__input" type="text" id="category-input">
          <label class="mdl-textfield__label" for="category-input">Categoria</label>
        </div>     
        <div class="input-text mdl-textfield mdl-js-textfield">
          <input class="mdl-textfield__input" type="text" id="comment-input">
          <label class="mdl-textfield__label" for="comment-input">Comentário</label>
        </div>
        <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--colored">
          Enviar Sugestão
        </button>
      </form>    
    </div>
  </div>
</template>

<script>

export default {
  name: 'suggestion-box',
  data () {
    return {
      msg: 'SuggestionBox'
    }
  }
}
</script>

<style scoped>

    .suggestion-box {
      padding: 2em;
    }

    .input-container.mdl-card {
      display: flex;
      flex-direction: column;
      width: 500px;
      min-height: 64px;
      height: auto;
      align-items: center;
      justify-content: space-around;
      margin: 0 auto;
    }

    .input-icon {
      padding-right: 1em;
      padding-left: 1em;
    }

    .input-text {
      padding-right: 2em;
    }

    .mdl-button {
      margin: 30px;
    }
    

</style>
