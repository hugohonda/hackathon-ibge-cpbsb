<template>
  <div class="input-box">
    <div class="input-container mdl-card mdl-shadow--4dp">
      <i class="input-icon material-icons">{{ icon }}</i>
      <form action="#">
        <div class="input-text mdl-textfield mdl-js-textfield">
          <input class="mdl-textfield__input" type="text" id="location-input">
          <label class="mdl-textfield__label" for="location-input">{{ text }}</label>
        </div>
      </form>
      <button @click="getCounty(3304557)" class="mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--colored">
        Buscar
      </button>
    </div>
  </div>
</template>

<script>
import axios from 'axios'

export default {
  name: 'input-box',
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
      msg: 'InputBox'
    }
  },
  methods: {
    getCounty (countyId) {
      axios.get('http://api.sidra.ibge.gov.br/values/t/1552/n6/' + countyId + '/c2/all')
      .then(response => {
        console.log(response.data)
        this.posts = response.data
      })
      .catch(e => {
        this.errors.push(e)
      })
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
      height: 64px;
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
