<?php

/* base.html.twig */
class __TwigTemplate_93e2499d03c6402ea1e3906495568257ed0120721f7f5badb0e11600e82927c5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_ad7ad85b9a221a8e431738d1923fbdff22d5fa2a2e9e2808907877af9b8cdc36 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ad7ad85b9a221a8e431738d1923fbdff22d5fa2a2e9e2808907877af9b8cdc36->enter($__internal_ad7ad85b9a221a8e431738d1923fbdff22d5fa2a2e9e2808907877af9b8cdc36_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_887c4f012778a677545ecbc653f097584fb862978f1134047525bc375604b57a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_887c4f012778a677545ecbc653f097584fb862978f1134047525bc375604b57a->enter($__internal_887c4f012778a677545ecbc653f097584fb862978f1134047525bc375604b57a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 17
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 20
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 21
        $this->displayBlock('body', $context, $blocks);
        // line 24
        echo "</body>
</html>
";
        
        $__internal_ad7ad85b9a221a8e431738d1923fbdff22d5fa2a2e9e2808907877af9b8cdc36->leave($__internal_ad7ad85b9a221a8e431738d1923fbdff22d5fa2a2e9e2808907877af9b8cdc36_prof);

        
        $__internal_887c4f012778a677545ecbc653f097584fb862978f1134047525bc375604b57a->leave($__internal_887c4f012778a677545ecbc653f097584fb862978f1134047525bc375604b57a_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_f76a9dfe643bfe56cfe087a7e5d56bd0382330b2fc85ffb6444ea45d4b74a7ab = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f76a9dfe643bfe56cfe087a7e5d56bd0382330b2fc85ffb6444ea45d4b74a7ab->enter($__internal_f76a9dfe643bfe56cfe087a7e5d56bd0382330b2fc85ffb6444ea45d4b74a7ab_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_80a9bb7a51e662886cd84381e5760ceeb773b0fb09df0d82e477b91569b5c3d1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_80a9bb7a51e662886cd84381e5760ceeb773b0fb09df0d82e477b91569b5c3d1->enter($__internal_80a9bb7a51e662886cd84381e5760ceeb773b0fb09df0d82e477b91569b5c3d1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "IMDB";
        
        $__internal_80a9bb7a51e662886cd84381e5760ceeb773b0fb09df0d82e477b91569b5c3d1->leave($__internal_80a9bb7a51e662886cd84381e5760ceeb773b0fb09df0d82e477b91569b5c3d1_prof);

        
        $__internal_f76a9dfe643bfe56cfe087a7e5d56bd0382330b2fc85ffb6444ea45d4b74a7ab->leave($__internal_f76a9dfe643bfe56cfe087a7e5d56bd0382330b2fc85ffb6444ea45d4b74a7ab_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_820a34f765d18b30d112aea9ea956288545bd2264e561cfa12759bb7b7ec2e5d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_820a34f765d18b30d112aea9ea956288545bd2264e561cfa12759bb7b7ec2e5d->enter($__internal_820a34f765d18b30d112aea9ea956288545bd2264e561cfa12759bb7b7ec2e5d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_59550ff1196b8ee013139845e5a297bfd968235b46e8a7b8f5dea88a5688e590 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_59550ff1196b8ee013139845e5a297bfd968235b46e8a7b8f5dea88a5688e590->enter($__internal_59550ff1196b8ee013139845e5a297bfd968235b46e8a7b8f5dea88a5688e590_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        ";
        // line 14
        echo "        ";
        // line 15
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_59550ff1196b8ee013139845e5a297bfd968235b46e8a7b8f5dea88a5688e590->leave($__internal_59550ff1196b8ee013139845e5a297bfd968235b46e8a7b8f5dea88a5688e590_prof);

        
        $__internal_820a34f765d18b30d112aea9ea956288545bd2264e561cfa12759bb7b7ec2e5d->leave($__internal_820a34f765d18b30d112aea9ea956288545bd2264e561cfa12759bb7b7ec2e5d_prof);

    }

    // line 20
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_6f64fa67b859e0fe0b2f9ec69fc2c8cfb984faa53c348942b96ae7b06adf632e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6f64fa67b859e0fe0b2f9ec69fc2c8cfb984faa53c348942b96ae7b06adf632e->enter($__internal_6f64fa67b859e0fe0b2f9ec69fc2c8cfb984faa53c348942b96ae7b06adf632e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_b0d458a20f2d80a2bd55a56d85577c0b3f613c10d298cc8cab426e02b934aaee = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b0d458a20f2d80a2bd55a56d85577c0b3f613c10d298cc8cab426e02b934aaee->enter($__internal_b0d458a20f2d80a2bd55a56d85577c0b3f613c10d298cc8cab426e02b934aaee_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_b0d458a20f2d80a2bd55a56d85577c0b3f613c10d298cc8cab426e02b934aaee->leave($__internal_b0d458a20f2d80a2bd55a56d85577c0b3f613c10d298cc8cab426e02b934aaee_prof);

        
        $__internal_6f64fa67b859e0fe0b2f9ec69fc2c8cfb984faa53c348942b96ae7b06adf632e->leave($__internal_6f64fa67b859e0fe0b2f9ec69fc2c8cfb984faa53c348942b96ae7b06adf632e_prof);

    }

    // line 21
    public function block_body($context, array $blocks = array())
    {
        $__internal_cbe1214a5ae4558441316c4e8820ed56132a5ec04d6b739701c966812a5fa40a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_cbe1214a5ae4558441316c4e8820ed56132a5ec04d6b739701c966812a5fa40a->enter($__internal_cbe1214a5ae4558441316c4e8820ed56132a5ec04d6b739701c966812a5fa40a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_cf9cc8ed758c727302a1f4ba2273c9faf82e9e77038e07b9b5f589d61701053c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cf9cc8ed758c727302a1f4ba2273c9faf82e9e77038e07b9b5f589d61701053c->enter($__internal_cf9cc8ed758c727302a1f4ba2273c9faf82e9e77038e07b9b5f589d61701053c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 22
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_cf9cc8ed758c727302a1f4ba2273c9faf82e9e77038e07b9b5f589d61701053c->leave($__internal_cf9cc8ed758c727302a1f4ba2273c9faf82e9e77038e07b9b5f589d61701053c_prof);

        
        $__internal_cbe1214a5ae4558441316c4e8820ed56132a5ec04d6b739701c966812a5fa40a->leave($__internal_cbe1214a5ae4558441316c4e8820ed56132a5ec04d6b739701c966812a5fa40a_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_0adc92f0f40a3bd4f6f9a73c369b33677f797ab2212dc6235d20daa62d324f23 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_0adc92f0f40a3bd4f6f9a73c369b33677f797ab2212dc6235d20daa62d324f23->enter($__internal_0adc92f0f40a3bd4f6f9a73c369b33677f797ab2212dc6235d20daa62d324f23_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_a9a225ddacaa0901d586d6138a8884fa8dd6d2c3a8c94aec2bfc83148a8717ca = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a9a225ddacaa0901d586d6138a8884fa8dd6d2c3a8c94aec2bfc83148a8717ca->enter($__internal_a9a225ddacaa0901d586d6138a8884fa8dd6d2c3a8c94aec2bfc83148a8717ca_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_a9a225ddacaa0901d586d6138a8884fa8dd6d2c3a8c94aec2bfc83148a8717ca->leave($__internal_a9a225ddacaa0901d586d6138a8884fa8dd6d2c3a8c94aec2bfc83148a8717ca_prof);

        
        $__internal_0adc92f0f40a3bd4f6f9a73c369b33677f797ab2212dc6235d20daa62d324f23->leave($__internal_0adc92f0f40a3bd4f6f9a73c369b33677f797ab2212dc6235d20daa62d324f23_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 22,  129 => 21,  112 => 20,  99 => 15,  97 => 14,  95 => 13,  86 => 12,  68 => 11,  56 => 24,  54 => 21,  50 => 20,  43 => 17,  41 => 12,  37 => 11,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}IMDB{% endblock %}</title>
    {% block stylesheets %}
        {#<link rel=\"stylesheet\" href=\"{{ asset('css/reset-style.css') }}\">;#}
        {#<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\">#}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "D:\\PHP Skeleton\\app\\Resources\\views\\base.html.twig");
    }
}
