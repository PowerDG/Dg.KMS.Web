export const environment = {
  production: false,
  application: {
    name: 'KMS',
    logoUrl: ''
  },
  oAuthConfig: {
    issuer: 'https://localhost:44380',
    clientId: 'KMS_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'KMS',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44390'
    }
  },
  localization: {
    defaultResourceName: 'KMS'
  }
};
