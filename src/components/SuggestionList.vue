<template>
  <div class="suggestion-list mdl-card mdl-shadow--4dp">
    <div class="mdl-card__title">
      <h2 class="mdl-card__title-text">Lista de Sugestões</h2>
    </div>
    <ul class="demo-list-three mdl-list">
      <li class="mdl-list__item mdl-list__item--three-line">
        <span class="mdl-list__item-primary-content">
          <span>Igor Ribeiro</span>
          <span class="mdl-list__item-text-body">
            <b>Comércio<br></b>
            Bryan Cranston played the role of Walter in Breaking Bad. He is also known
            for playing Hal in Malcom in the Middle.
          </span>
        </span>
      </li>
      <li class="mdl-list__item mdl-list__item--three-line">
        <span class="mdl-list__item-primary-content">
          <span>Lucas Brilhante</span>
          <span class="mdl-list__item-text-body">
            <b>Construção<br></b>
            Bryan Cranston played the role of Walter in Breaking Bad. He is also known
            for playing Hal in Malcom in the Middle.
          </span>
        </span>
      </li>
      <li class="mdl-list__item mdl-list__item--three-line">
        <span class="mdl-list__item-primary-content">
          <span>Izabela Cardoso</span>
          <span class="mdl-list__item-text-body">
            <b>Alimentos<br></b>
            Bob Odinkrik played the role of Saul in Breaking Bad. Due to public fondness for the
            character, Bob stars in his own show now, called "Better Call Saul".
          </span>
        </span>
      </li>
    </ul>
  </div>
</template>

<script>

export default {
  name: 'suggestion-list',
  data () {
    return {
      msg: 'SuggestionList'
    }
  }
}
</script>

<style scoped>

  .suggestion-list {
    width: 650px;
    margin: 20px auto;
  }

  .mdl-list__item {
    text-align: left;
  }

</style>
