<template>
  <div class="input-box">
    <div class="input-container mdl-card mdl-shadow--4dp">
      <form action="#">
        <div class="input-text mdl-textfield mdl-js-textfield">
          <input class="mdl-textfield__input" type="text" id="name-input">
          <label class="mdl-textfield__label" for="name-input">Nome</label>
        </div>
        <div class="mdl-selectfield mdl-js-selectfield">
        <select class="mdl-selectfield__select" id="category" name="category">
          <option value=""></option>
          <option value="option1">Comércio</option>
          <option value="option2">Construção</option>
        </select>
        <label class="mdl-selectfield__label" for="category">Categoria de Negócio</label>
      </div>
        <div class="input-text mdl-textfield mdl-js-textfield">
          <input class="mdl-textfield__input" type="text" id="comment-input">
          <label class="mdl-textfield__label" for="comment-input">Comentário</label>
        </div>
      </form>
      <button class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--colored">
        Buscar
      </button>
    </div>
  </div>
</template>

<script>
export default {
  name: 'suggestion-box',
  props: {
    text: {
      type: String
    },
    icon: {
      type: String
    }
  },
  data () {
    return {
      msg: 'SuggestionBox'
    }
  }
}
</script>

<style scoped>

    .input-box {
      padding: 2em;
    }

    .input-container.mdl-card {
      display: flex;
      flex-direction: row;
      width: 620px;
      min-height: 64px;
      height: auto;
      align-items: center;
      justify-content: space-around;
    }

    .input-icon {
      padding-right: 1em;
      padding-left: 1em;
    }

    .input-text {
      padding-right: 2em;
    }

</style>
