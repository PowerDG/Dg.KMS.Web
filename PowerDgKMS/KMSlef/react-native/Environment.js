const ENV = {
  dev: {
    apiUrl: 'http://localhost:44318',
    oAuthConfig: {
      issuer: 'http://localhost:44318',
      clientId: 'KMS_App',
      clientSecret: '1q2w3e*',
      scope: 'KMS',
    },
    localization: {
      defaultResourceName: 'KMS',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44318',
    oAuthConfig: {
      issuer: 'http://localhost:44318',
      clientId: 'KMS_App',
      clientSecret: '1q2w3e*',
      scope: 'KMS',
    },
    localization: {
      defaultResourceName: 'KMS',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
