// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'
import router from './router' 
import { DatePicker } from 'ant-design-vue';
Vue.use(DatePicker);
Vue.config.productionTip = false
import 'ant-design-vue/dist/antd.css'; // or 'ant-design-vue/dist/antd.less'
/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
