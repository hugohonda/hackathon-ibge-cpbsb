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
    </div>
  </div>
</template>

<script>
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
      min-width: 360px;
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
