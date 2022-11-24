package com.rocketteam.d3vs.activities;

import java.lang.System;

@kotlin.Metadata(mv = {1, 7, 1}, k = 1, d1 = {"\u0000h\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0005\u00a2\u0006\u0002\u0010\u0002J\u0012\u0010\"\u001a\u00020#2\b\u0010$\u001a\u0004\u0018\u00010%H\u0002J\u0012\u0010&\u001a\u00020#2\b\u0010$\u001a\u0004\u0018\u00010%H\u0002J\"\u0010\'\u001a\u00020#2\u0006\u0010(\u001a\u00020)2\u0006\u0010*\u001a\u00020)2\b\u0010+\u001a\u0004\u0018\u00010\u0004H\u0014J\u0012\u0010,\u001a\u00020#2\b\u0010-\u001a\u0004\u0018\u00010.H\u0014J\b\u0010/\u001a\u00020#H\u0014R\u001c\u0010\u0003\u001a\u0004\u0018\u00010\u0004X\u0086\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b\u0005\u0010\u0006\"\u0004\b\u0007\u0010\bR\u0010\u0010\t\u001a\u0004\u0018\u00010\nX\u0082\u000e\u00a2\u0006\u0002\n\u0000R\u0010\u0010\u000b\u001a\u0004\u0018\u00010\fX\u0082\u000e\u00a2\u0006\u0002\n\u0000R\u0010\u0010\r\u001a\u0004\u0018\u00010\u000eX\u0082\u000e\u00a2\u0006\u0002\n\u0000R\u0010\u0010\u000f\u001a\u0004\u0018\u00010\u0010X\u0082\u000e\u00a2\u0006\u0002\n\u0000R\u0010\u0010\u0011\u001a\u0004\u0018\u00010\u0010X\u0082\u000e\u00a2\u0006\u0002\n\u0000R\u001c\u0010\u0012\u001a\u0004\u0018\u00010\u0013X\u0086\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b\u0014\u0010\u0015\"\u0004\b\u0016\u0010\u0017R\"\u0010\u0018\u001a\n\u0012\u0004\u0012\u00020\u0004\u0018\u00010\u0019X\u0086\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b\u001a\u0010\u001b\"\u0004\b\u001c\u0010\u001dR\u0010\u0010\u001e\u001a\u0004\u0018\u00010\u001fX\u0082\u000e\u00a2\u0006\u0002\n\u0000R\u0010\u0010 \u001a\u0004\u0018\u00010!X\u0082\u000e\u00a2\u0006\u0002\n\u0000\u00a8\u00060"}, d2 = {"Lcom/rocketteam/d3vs/activities/Login;", "Landroidx/appcompat/app/AppCompatActivity;", "()V", "SignInIntent", "Landroid/content/Intent;", "getSignInIntent", "()Landroid/content/Intent;", "setSignInIntent", "(Landroid/content/Intent;)V", "btEntrar", "Landroid/widget/Button;", "btGoogle", "Lcom/google/android/gms/common/SignInButton;", "db", "Lcom/rocketteam/d3vs/db/D3vzAPIConsumer;", "edtEmail", "Landroid/widget/EditText;", "edtSenha", "gso", "Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;", "getGso", "()Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;", "setGso", "(Lcom/google/android/gms/auth/api/signin/GoogleSignInOptions;)V", "startForResult", "Landroidx/activity/result/ActivityResultLauncher;", "getStartForResult", "()Landroidx/activity/result/ActivityResultLauncher;", "setStartForResult", "(Landroidx/activity/result/ActivityResultLauncher;)V", "switchProf", "Landroid/widget/Switch;", "toolBar2", "Landroidx/appcompat/widget/Toolbar;", "btEntrarOnClick", "", "it", "Landroid/view/View;", "btGoogleOnClick", "onActivityResult", "requestCode", "", "resultCode", "data", "onCreate", "savedInstanceState", "Landroid/os/Bundle;", "onResume", "app_debug"})
public final class Login extends androidx.appcompat.app.AppCompatActivity {
    private android.widget.EditText edtSenha;
    private android.widget.EditText edtEmail;
    private android.widget.Switch switchProf;
    private com.google.android.gms.common.SignInButton btGoogle;
    private android.widget.Button btEntrar;
    private androidx.appcompat.widget.Toolbar toolBar2;
    @org.jetbrains.annotations.Nullable()
    private androidx.activity.result.ActivityResultLauncher<android.content.Intent> startForResult;
    private com.rocketteam.d3vs.db.D3vzAPIConsumer db;
    @org.jetbrains.annotations.Nullable()
    private com.google.android.gms.auth.api.signin.GoogleSignInOptions gso;
    @org.jetbrains.annotations.Nullable()
    private android.content.Intent SignInIntent;
    
    public Login() {
        super();
    }
    
    @org.jetbrains.annotations.Nullable()
    public final androidx.activity.result.ActivityResultLauncher<android.content.Intent> getStartForResult() {
        return null;
    }
    
    public final void setStartForResult(@org.jetbrains.annotations.Nullable()
    androidx.activity.result.ActivityResultLauncher<android.content.Intent> p0) {
    }
    
    @org.jetbrains.annotations.Nullable()
    public final com.google.android.gms.auth.api.signin.GoogleSignInOptions getGso() {
        return null;
    }
    
    public final void setGso(@org.jetbrains.annotations.Nullable()
    com.google.android.gms.auth.api.signin.GoogleSignInOptions p0) {
    }
    
    @java.lang.Override()
    protected void onCreate(@org.jetbrains.annotations.Nullable()
    android.os.Bundle savedInstanceState) {
    }
    
    @java.lang.Override()
    protected void onResume() {
    }
    
    @java.lang.Override()
    protected void onActivityResult(int requestCode, int resultCode, @org.jetbrains.annotations.Nullable()
    android.content.Intent data) {
    }
    
    @org.jetbrains.annotations.Nullable()
    public final android.content.Intent getSignInIntent() {
        return null;
    }
    
    public final void setSignInIntent(@org.jetbrains.annotations.Nullable()
    android.content.Intent p0) {
    }
    
    private final void btGoogleOnClick(android.view.View it) {
    }
    
    private final void btEntrarOnClick(android.view.View it) {
    }
}